[string]$MigrationName = $null
while ([string]::IsNullOrWhitespace($MigrationName)) {
	$MigrationName = Read-Host "Migration name"
}

dotnet ef migrations add $MigrationName --project ../Libraries/ExchangeRateUpdaterCk.Data -s ../Presentation/ExchangeRateUpdaterCk.Api/ExchangeRateUpdaterCk.Api.csproj

dotnet ef database update --project ../Libraries/ExchangeRateUpdaterCk.Data -s ../Presentation/ExchangeRateUpdaterCk.Api/ExchangeRateUpdaterCk.Api.csproj