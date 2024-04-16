/**
 * Initializes PostgreSQL database instance for ExatoLP Web application.
 * 
 * 1. Creates the database instance "ufrgs-exatolp-web".
 * 2. Creates the following users:
 *   - admin: Administrator user with superuser privileges.
 *   - migration: Migration user to create, update and delete structures, as well as add metadata.
 *   - application: Application user to select, insert, update and delete data.
 */

-- read environment variables

\getenv exatolp_admin_password exatolp_admin_password
\getenv exatolp_migration_password exatolp_migration_password
\getenv exatolp_application_password exatolp_application_password
\set

-- run statements in "postgres" context

create user admin with password :'exatolp_admin_password';
alter user admin with superuser;

create database "ufrgs-exatolp-web" encoding = 'UTF8' owner = admin;

\c "ufrgs-exatolp-web"

-- run statements in "ufrgs-exatolp-web" context

create user migration with password :'exatolp_migration_password';
grant usage, create on schema public to migration;
alter default privileges in schema public grant select on tables to migration;
alter default privileges in schema public grant execute on functions to migration;
alter default privileges in schema public grant usage on sequences to migration;

create user application with password :'exatolp_application_password';
grant usage on schema public to application;
alter default privileges for role migration in schema public grant all on tables to application;
alter default privileges for role migration in schema public grant execute on functions to application;
alter default privileges for role migration in schema public grant all on sequences to application;
alter default privileges for role migration in schema public grant usage on types to application;
alter default privileges for role admin in schema public grant all on tables to application;
alter default privileges for role admin in schema public grant execute on functions to application;
alter default privileges for role admin in schema public grant usage on sequences to application;
alter default privileges for role admin in schema public grant usage on types to application;
alter default privileges for role postgres in schema public grant all on tables to application;
alter default privileges for role postgres in schema public grant execute on functions to application;
alter default privileges for role postgres in schema public grant usage on sequences to application;
alter default privileges for role postgres in schema public grant usage on types to application;
