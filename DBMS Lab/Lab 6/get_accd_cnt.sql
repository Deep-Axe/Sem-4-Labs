CREATE OR REPLACE FUNCTION get_accidents_by_year(year INT)
RETURN INT
IS
    Accident_Count INT;
BEGIN
    SELECT COUNT(*) 
    INTO Accident_Count
    FROM ACCIDENT 
    WHERE EXTRACT(YEAR FROM accd_date) = year;

    RETURN Accident_Count;
END;
/
