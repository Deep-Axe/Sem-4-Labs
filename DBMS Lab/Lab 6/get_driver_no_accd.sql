CREATE OR REPLACE PROCEDURE GetDriversNotInvolvedInAccidents IS
BEGIN
    FOR rec IN (
        SELECT p.driver_id, p.name, p.address
        FROM PERSON p
        LEFT JOIN PARTICIPATED pa ON p.driver_id = pa.driver_id
        WHERE pa.driver_id IS NULL 
    ) LOOP
        DBMS_OUTPUT.PUT_LINE('Driver ID: ' || rec.driver_id);
        DBMS_OUTPUT.PUT_LINE('Name: ' || rec.name);
        DBMS_OUTPUT.PUT_LINE('Address: ' || rec.address);
        DBMS_OUTPUT.PUT_LINE('-----------------------------');
    END LOOP;
END;
/
