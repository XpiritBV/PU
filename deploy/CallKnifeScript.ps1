Invoke-Knife @("azure server create --azure-dns-name 'xp-cheftst' --azure-vm-name 'cheftst1' --azure-vm-size 'Small' --azure-storage-account 'portalvhdscheftst' --bootstrap-protocol 'cloud-api' --azure-source-image 'a699494373c04fc0bc8f2bb1389d6106__Windows-Server-2012-Datacenter-201411.01-en.us-127GB.vhd' --azure-service-location 'West Europe' --winrm-user azureuser --winrm-password 'myPassword123' --tcp-endpoints 80,3389 --r 'recipe[webserver]'")