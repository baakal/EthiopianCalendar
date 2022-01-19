CREATE or replace FUNCTION gr_to_et(input_date timestamptz, format int)
    RETURNS text
    LANGUAGE plpgsql
as
$$
    --Gregorian Dates
    DECLARE d         int       := extract(day from input_date);
    DECLARE m         int       := extract(month from input_date);
    DECLARE y         int       := extract(year from input_date);
    DECLARE dw        int       := extract(dow from input_date);
    --Ethiopian Dates
    DECLARE et_months varchar[] := '{"መስከረም", "ጥቅምት", "ኅዳር", "ታኅሣሥ", "ጥር", "የካቲት", "መጋቢት", "ሚያዝያ", "ግንቦት", "ሰኔ", "ሐምሌ", "ነሐሴ", "ጳጉሜን"}';
    DECLARE et_days   varchar[] := '{"እሑድ", "ሰኞ", "ማክሰኞ", "ረቡዕ", "ሓሙስ", "ዓርብ", "ቅዳሜ"}';
    DECLARE et_d      int;
    DECLARE et_m      int;
    DECLARE et_y      int;
    --Julian Dates
    DECLARE jdn       int;
    DECLARE jd_offset int       := 1723856;
    --
    DECLARE a         int;
    DECLARE b         int;
    DECLARE c         int;
    DECLARE e         int;
    DECLARE f         int;

BEGIN
    --Minimum supprorted date: 25/1/1800
    --Maximum supported date: 31/12/2199

    --Converting to Julian Date
    a = (14 - m) / 12;
    b = y + 4800 - a;
    c = m + 12 * a - 3;
    jdn = (d + (153 * c + 2) / 5 + 365 * b + b / 4 - b / 100 + b / 400 - 32045);
    --Converting to Ethiopian Date from Julian (Formula from Dr. Berhanu Beyene and Manfred Kudlek)
    e = (jdn - jd_offset) % 1461;
    f = e % 365 + 365 * (e / 1460);
    et_y = 4 * ((jdn - jd_offset) / 1461) + e / 365 - e / 1460;
    et_m = f / 30 + 1;
    et_d = f % 30 + 1;

    return case
               when format = 1
                   then
                   et_d || '-' || et_m || '-' || et_y
               else case
                        when format = 2
                            then et_days[dw + 1] || ' ' || et_months[et_m] || ' ' || et_d || ',' || et_y
                        else case
                                 when format = 3
                                     then et_months[et_m] || ' ' || et_d || ',' || et_y end end end;

end
$$;