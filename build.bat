if not exist ArchiSteamFarm\ArchiSteamFarm (git submodule update --init)
git submodule foreach "git fetch origin; git checkout $(git rev-list --tags --max-count=1);"
del .\Ryzhehvost.CaseInsensitiveASF\*.zip
dotnet publish -c "Release" -f "net48" -o "out/generic-netf"
rename .\Ryzhehvost.CaseInsensitiveASF\CaseInsensitiveASF.zip CaseInsensitiveASF-netf.zip 
dotnet publish -c "Release" -f "netcoreapp3.1" -o "out/generic" "/p:LinkDuringPublish=false"