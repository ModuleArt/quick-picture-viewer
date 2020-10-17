$(document).ready(function () {
    let converter = new showdown.Converter();

    $.getJSON("https://api.github.com/repos/ModuleArt/quick-picture-viewer/releases/latest").done(function (json) {
        
        // download link
        let downloadLink = document.getElementById("download-link");
        downloadLink.href = "https://github.com/ModuleArt/quick-picture-viewer/releases/download/" + json.tag_name + "/QuickPictureViewer-Setup.exe";
        downloadLink.getElementsByClassName("version")[0].innerHTML = json.tag_name;

        // what's new
        let whatsNewLink = document.getElementById("whats-new").getElementsByClassName("release-title")[0];
        whatsNewLink.innerHTML = json.name;
        whatsNewLink.href = "https://github.com/ModuleArt/quick-picture-viewer/releases/tag/" + json.tag_name;
        document.getElementById("whats-new").getElementsByClassName("release-date")[0].innerHTML = " - " + new Date(json.published_at).toLocaleDateString('en-US', {
            day: '2-digit',
            month: '2-digit',
            year: 'numeric',
          })
        document.getElementById("whats-new").getElementsByClassName("release-markdown")[0].innerHTML = converter.makeHtml(json.body);

        // copyright year
        document.getElementById("copyright").innerHTML = "Copyright © " + new Date().getFullYear() + " Module Art";
    });
});