CREATE OR REPLACE FUNCTION
Get_Username
(
	p_Username IN monei_user.Username%TYPE
	)
RETURN VARCHAR2
AS
    v_Username VARCHAR2;
BEGIN
    SELECT username INTO v_Username FROM monei_user WHERE p_Username = username;
    RETURN v_Username;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        p_Username := null;    
END;