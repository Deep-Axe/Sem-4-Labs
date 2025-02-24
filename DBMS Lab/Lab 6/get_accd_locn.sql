CREATE OR REPLACE PROCEDURE GetAccidentInfoByLocation(
    p_location IN VARCHAR2
) IS
    v_fnd BOOLEAN := False;
BEGIN
    FOR rec IN (
        SELECT a.report_number, a.accd_date, a.location, p.damage_amount
        FROM ACCIDENT a
        JOIN PARTICIPATED p ON a.report_number = p.report_number
        WHERE a.location = p_location
    ) LOOP
        DBMS_OUTPUT.PUT_LINE('Report Number: ' || rec.report_number);
        DBMS_OUTPUT.PUT_LINE('Accident Date: ' || TO_CHAR(rec.accd_date, 'YYYY-MM-DD'));
        DBMS_OUTPUT.PUT_LINE('Location: ' || rec.location);
        DBMS_OUTPUT.PUT_LINE('Damage Amount: ' || rec.damage_amount);
        DBMS_OUTPUT.PUT_LINE('-----------------------------');

        v_fnd := True;
    END LOOP;

    IF not v_fnd THEN
        DBMS_OUTPUT.PUT_LINE('No accidents found in the specified location: ' || p_location);
    END IF;
END;
/
