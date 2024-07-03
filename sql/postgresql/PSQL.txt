## PostgreSQL

### Installation / Entering PSQL
- Update linux & type "sudo apt-get install postgresql-contrib" in the terminal
- To get to psql, type "sudo su postgres" then "psql" in the terminal
  - Another way is to type "sudo -u postgres psql" in the terminal
  - Another way is to type "sudo -i -u postgres" & then "psql" in the terminal
  - Another way, and to enter as the user you want, is to type "sudo -u (user) psql" in terminal
- "\q" or "exit" will exit psql

### Users
- To create a user, type "CREATE USER (user) WITH PASSWORD '(password)';" in psql
  - Another way is to type  "sudo -u postgres createuser --interactive" in the terminal
- To add attributes to a user, type "ALTER USER (user) WITH (attribute);" in psql
- To show how many users there are, type "\du" in psql
- To delete a user, type "DROP USER (user);" in psql

### Databases
- To create a database type "CREATE DATABASE (database);" in psql
  - Another way is to type "sudo -u postgres createdb (database)" in the terminal
- (Necessary for every database): To configure the database type "psql -h localhost -p 5432 -U postgres (database)" in the terminal
- To allow a user to do anything with a database, type "GRANT ALL PRIVILEGES ON DATABASE (database) TO (user);"
- To switch to a database, type "\c (database)" in psql
- To know what user/database you're in, type "\conninfo" into the psql
- To show how many databases there are, type "\l" in psql
- To delete a database, type "DROP DATABASE (database);" in psql

### \i & \o Commands
- Must configue the database before using these commands (check above)
- Type "\i (file path)" to execute the commands from a file
- Type "\o (file path)" then "(queries)" then "\o" to send all query results to a file
