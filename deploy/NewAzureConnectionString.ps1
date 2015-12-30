#NewAzureConnectionString
param (
    [string]$webappname,
	[string]$connectionStringName,
	[string]$connectionStringValue
)

#http://www.muddlingthru.ca/configure-azure-website-connection-strings-with-powershell
#https://gallery.technet.microsoft.com/scriptcenter/Deploy-a-Windows-Azure-Web-790cacd2
#https://azure.microsoft.com/en-us/blog/windows-azure-web-sites-how-application-strings-and-connection-strings-work/

#AzureConnectionString
$appDBConnStrInfo = New-Object Microsoft.WindowsAzure.Commands.Utilities.Websites.Services.WebEntities.ConnStringInfo; 
$appDBConnStrInfo.Name=$connectionStringName
$appDBConnStrInfo.ConnectionString=$connectionStringValue; 
$appDBConnStrInfo.Type="SQLAzure"; 


# Add new ConnStringInfo objecto list of connection strings for website. 
$connStrSettings = (Get-AzureWebsite $webappname).ConnectionStrings; 

$res = $connStrSettings.Find({ param($m) $m.Name.Equals($connectionStringName) })
if ($res)
{
    Write-Host "Found a exisiting Connection String. Updating Value"
    $connStrSettings.Find({ param($m) $m.Name.Equals("$connectionStringName") }).ConnectionString = $connectionStringValue
}
else
{
    Write-Host "Not Found a exisiting Connection String. Create new one"

    $appDBConnStrInfo = New-Object Microsoft.WindowsAzure.Commands.Utilities.Websites.Services.WebEntities.ConnStringInfo; 
    $appDBConnStrInfo.Name=$connectionStringName
    $appDBConnStrInfo.ConnectionString=$connectionStringValue; 
    $appDBConnStrInfo.Type="SQLAzure";
    $connStrSettings.Add($appDBConnStrInfo); 
}

#$connStrSettings.Remove($appDBConnStrInfo); 
#Set-AzureWebsite -Name $webappname -ConnectionStrings $connStrSettings 

#$connStrSettings.Add($appDBConnStrInfo); 
Set-AzureWebsite -Name $webappname -ConnectionStrings $connStrSettings 

