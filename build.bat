del .\Ryzhehvost.CaseInsensitiveASF\*.zip
dotnet publish -c "Release" -f "net472" -o "out/generic-netf"
rename .\Ryzhehvost.CaseInsensitiveASF\CaseInsensitiveASF.zip CaseInsensitiveASF-netf.zip 
dotnet publish -c "Release" -f "netcoreapp2.2" -o "out/generic" "/p:LinkDuringPublish=false"