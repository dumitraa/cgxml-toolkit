param($installPath, $toolsPath, $package, $project)

$pdftkPath = Join-Path (Join-Path $toolsPath 'pdftk') 'bin'

foreach($file in (get-childitem $pdftkPath)) {
    $project.ProjectItems.Item($file.Name).Delete()
}