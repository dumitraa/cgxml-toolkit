param($installPath, $toolsPath, $package, $project)

$pdftkPath = Join-Path (Join-Path $toolsPath 'pdftk') 'bin'

foreach($file in (get-childitem $pdftkPath)) {
    $project.ProjectItems.AddFromFile($file.FullName);
    $pi = $project.ProjectItems.Item($file.Name);
    $pi.Properties.Item("BuildAction").Value = [int]2;
    $pi.Properties.Item("CopyToOutputDirectory").Value = [int]2;
}