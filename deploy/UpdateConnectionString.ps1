#UpdateConnectionString
param (
	[string]$websiteRootFolder,
	[string]$connectionStringKeyName,
	[string]$newValue
)

Write-Verbose "Starting Updating COnfig Task" -Verbose

#http://blogs.msdn.com/b/sonam_rastogi_blogs/archive/2014/08/18/update-configuration-files-using-powershell.aspx

$webConfig = join-path $websiteRootFolder  "web.config"

Write-Verbose "webconfig $webConfig" -Verbose


$xml = (Get-Content $webConfig) -as [Xml]
Write-Verbose "xml $xml" -Verbose
 

$target = $xml.SelectSingleNode("//configuration/connectionStrings/add[@name='$connectionStringKeyName']")

Write-Verbose "target $target" -Verbose

$target.SetAttribute("connectionString", "$newValue");

$xml.Save($webConfig)

