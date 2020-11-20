#!/bin/sh
for tenant in kittyme doggyme
do
    az appconfig kv set -n $APPCNAME --key $tenant:Sentinel -y --value `date +%s` &
done