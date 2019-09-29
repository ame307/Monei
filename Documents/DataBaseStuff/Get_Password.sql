CREATE OR REPLACE PROCEDURE 
Get_Password (
	p_Username IN OUT monei_user.Username%TYPE,
    p_Password OUT monei_user.Password%TYPE
	)
AS
BEGIN
    SELECT password INTO p_Password FROM monei_user WHERE p_Username = username;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        p_Username := null; 
END;