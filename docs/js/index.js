$(document).ready(function () {
    let converter = new showdown.Converter();

    $.getJSON("https://api.github.com/repos/ModuleArt/quick-picture-viewer/releases/latest").done(function(json) {

        // download link
        let downloadLink = document.getElementById("download-link");
        downloadLink.href = "https://github.com/ModuleArt/quick-picture-viewer/releases/download/" + json.tag_name + "/QuickPictureViewer-Setup.exe";
        downloadLink.getElementsByClassName("version")[0].innerHTML = json.tag_name;
        downloadLink.getElementsByClassName("size")[0].innerHTML = "Win 7-10, " + formatBytes(json.assets[0].size);

        // what's new
        let whatsNewLink = document.getElementById("whats-new").getElementsByClassName("release-title")[0];
        whatsNewLink.innerHTML = json.name;
        whatsNewLink.href = "https://github.com/ModuleArt/quick-picture-viewer/releases/tag/" + json.tag_name;
        document.getElementById("whats-new").getElementsByClassName("release-date")[0].innerHTML = " - " + new Date(json.published_at).toLocaleDateString('en-US', {
            day: '2-digit',
            month: '2-digit',
            year: 'numeric',
        });
        document.getElementById("whats-new").getElementsByClassName("release-markdown")[0].innerHTML = converter.makeHtml(json.body);

        // copyright year
        document.getElementById("copyright").innerHTML = "Copyright © " + new Date().getFullYear() + " Module Art";
    });
});

function formatBytes(bytes, decimals = 1) {
    if (bytes === 0) return '0 Bytes';

    const k = 1024;
    const dm = decimals < 0 ? 0 : decimals;
    const sizes = ['Bytes', 'KB', 'MB', 'GB', 'TB', 'PB', 'EB', 'ZB', 'YB'];

    const i = Math.floor(Math.log(bytes) / Math.log(k));

    return parseFloat((bytes / Math.pow(k, i)).toFixed(dm)) + ' ' + sizes[i];
}