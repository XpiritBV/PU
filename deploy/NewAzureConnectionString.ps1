#NewAzureConnectionString
param (
    [string]$webappname,
	[string]$connectionStringName,
	[string]$connectionStringValue
)


#https://gallery.technet.microsoft.com/scriptcenter/Deploy-a-Windows-Azure-Web-790cacd2
#https://azure.microsoft.com/en-us/blog/windows-azure-web-sites-how-application-strings-and-connection-strings-work/

#AzureConnectionString
$appDBConnStrInfo = New-Object Microsoft.WindowsAzure.Commands.Utilities.Websites.Services.WebEntities.ConnStringInfo; 
$appDBConnStrInfo.Name=$connectionStringName
$appDBConnStrInfo.ConnectionString=$connectionStringValue; 
$appDBConnStrInfo.Type="SQLAzure"; 


# Add new ConnStringInfo objecto list of connection strings for website. 
$connStrSettings = (Get-AzureWebsite $webappname).ConnectionStrings; 
$connStrSettings.Add($appDBConnStrInfo); 

Set-AzureWebsite -Name $webappname -ConnectionStrings $connStrSettings 

