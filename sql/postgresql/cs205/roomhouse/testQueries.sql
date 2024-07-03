/* This query will list every time a customer stayed at the room house with the
most expensive visits at the top */
SELECT * FROM STAY
ORDER BY AMOUNTDUE DESC;

/* This query will list all stays from 2/28/2021 - 4/1/2021 */
SELECT * FROM STAY
WHERE STARTDATE>='2/28/2021' AND ENDDATE<='4/1/2021'
ORDER BY STARTDATE;

/* This query will give the average of the amount due of each customer to the
second decimal place */
SELECT CAST(AVG(AMOUNTDUE) AS DECIMAL(10,2)) AS AMOUNTDUEAVERAGE
FROM STAY;

/* This query will list every instance that a customer changed the date of their
reservation or cancelled it */
SELECT CUSTOMER.CUSTOMERID, CUSTOMER.NAME, RESERVATION.DATECHANGED, RESERVATION.CANCELLED
FROM RESERVATION
INNER JOIN CUSTOMER ON CUSTOMER.CUSTOMERID=RESERVATION.CUSTOMERID
WHERE RESERVATION.DATECHANGED='Y' OR RESERVATION.CANCELLED='Y';

/* This query will list the amount of times each customer stayed at a room
in the room house with the customer who stayed the most at top*/
SELECT CUSTOMER.CUSTOMERID, CUSTOMER.NAME, COUNT(STAY.CUSTOMERID) AS AMOUNTOFSTAYS
FROM CUSTOMER, STAY
WHERE CUSTOMER.CUSTOMERID=STAY.CUSTOMERID
GROUP BY CUSTOMER.CUSTOMERID, CUSTOMER.NAME
ORDER BY AMOUNTOFSTAYS DESC;

/* This query will determine how much the customer with the most amount of visits
has spent in all of their visits */
SELECT CUSTOMER.CUSTOMERID, CUSTOMER.NAME, SUM(STAY.AMOUNTDUE)
FROM CUSTOMER, STAY
WHERE CUSTOMER.CUSTOMERID=STAY.CUSTOMERID AND
STAY.CUSTOMERID='C7'
GROUP BY CUSTOMER.CUSTOMERID, CUSTOMER.NAME;