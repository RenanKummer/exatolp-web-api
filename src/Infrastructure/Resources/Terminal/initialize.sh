#!/bin/bash

###
# Initializes PostgreSQL database instance for ExatoLP Web application.
#
# Required environment variables:
#   - POSTGRES_PASSWORD: Password for the default 'postgres' user.
#   - exatolp_admin_password: Password for the 'admin' user.
#   - exatolp_migration_password: Password for the 'migration' user.
#   - exatolp_application_password: Password for the 'application' user.
#
# Required files:
#   - /exatolp/database/scripts/initialize.sql: SQL script to initialize the database.
##

# Check if env variables are set
if [[ -z "$POSTGRES_PASSWORD" || -z "$exatolp_admin_password" || 
      -z "$exatolp_migration_password" || -z "$exatolp_application_password" ]]; then
  echo "Error: Required environment variables are not set."
  exit 1
fi

# Check if initialize.sql exists
if [[ ! -f "/exatolp/database/scripts/initialize.sql" ]]; then
  echo "Error: /exatolp/database/scripts/initialize.sql does not exist."
  exit 1
fi

# Run psql command
psql -U postgres -f /exatolp/database/scripts/initialize.sql

# Check the exit code of psql command
if [[ $? -ne 0 ]]; then
  echo "Warning: Failed to initialize PostgreSQL database: please review the output messages."
  exit 1
fi

# Clear env variables
unset POSTGRES_PASSWORD
unset exatolp_admin_password
unset exatolp_migration_password
unset exatolp_application_password

echo "Success: PostgreSQL database initialized successfully."
exit 0
