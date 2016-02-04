param (
	[string]$webappname,
	[string]$slotName,
	[string]$percentage
)
Write-Host "Setting slot on webapp $webappname slotname $slotName to $percentage % trafic"
$rule = New-Object Microsoft.WindowsAzure.Commands.Utilities.Websites.Services.WebEntities.RampUpRule
$rule.ActionHostName = "$webappname-$slotName.azurewebsites.net"
$rule.ReroutePercentage = $percentage
$rule.Name = "canary-$percentage"
Set-AzureWebsite $webappname -Slot $slotName -RoutingRules $rule