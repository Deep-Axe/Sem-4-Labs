CREATE OR REPLACE PROCEDURE GetTotalDamageForDriverInYear(
    p_driver_id IN VARCHAR2,
    p_year IN NUMBER
) IS
    total_damage NUMBER := 0;
BEGIN
   
    SELECT SUM(p.damage_amount) INTO total_damage
    FROM PARTICIPATED p
    JOIN OWNS o ON p.driver_id = o.driver_id
    JOIN ACCIDENT a ON p.report_number = a.report_number
    WHERE p.driver_id = p_driver_id
      AND EXTRACT(YEAR FROM a.accd_date) = p_year;
    IF total_damage IS NULL OR total_damage = 0 THEN
        DBMS_OUTPUT.PUT_LINE('No damage for specific year');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Total Damage: ' || total_damage);
    END IF;
END;
/
