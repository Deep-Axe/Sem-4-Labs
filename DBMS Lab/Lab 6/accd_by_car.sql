CREATE OR REPLACE FUNCTION GetAccidentsByCar (
    p_regno IN VARCHAR2
) RETURN NUMBER IS
    v_accident_count NUMBER := 0;
BEGIN
    SELECT COUNT(DISTINCT pa.report_number)
    INTO v_accident_count
    FROM PARTICIPATED pa
    WHERE pa.regno = p_regno;
    RETURN v_accident_count;
EXCEPTION
    WHEN OTHERS THEN
        RETURN 0;
END;
/
