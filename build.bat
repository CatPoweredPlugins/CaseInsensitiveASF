del .\Ryzhehvost.CaseInsensitiveASF\*.zip
dotnet publish -c "Release" -f "net48" -o "out/generic-netf"
rename .\Ryzhehvost.CaseInsensitiveASF\CaseInsensitiveASF.zip CaseInsensitiveASF-netf.zip 
dotnet publish -c "Release" -f "netcoreapp3.0" -o "out/generic" "/p:LinkDuringPublish=false"