param (
	[string]$webAppName,
	[string]$productionSlotName,
	[string]$canarySlotName,
	[string]$percentage
)
Write-Host "Setting slot on webapp $webAppName slotname $canarySlotName to $percentage % trafic"
$rule = New-Object Microsoft.WindowsAzure.Commands.Utilities.Websites.Services.WebEntities.RampUpRule
$rule.ActionHostName = $canarySlotName
$rule.ReroutePercentage = $percentage
$rule.Name = "canary-$percentage"
Set-AzureWebsite $webAppName -Slot $productionSlotName -RoutingRules $rule