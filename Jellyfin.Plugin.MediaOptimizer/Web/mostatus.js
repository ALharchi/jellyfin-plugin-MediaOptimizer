const getConfigurationPageUrl = (name) => {
    return 'configurationpage?name=' + encodeURIComponent(name);
}

function getTabs() {
    //console.log(window)
    var tabs = [
        {
            href: getConfigurationPageUrl('mostatus'),
            name: 'Status'
        },
        {
            href: getConfigurationPageUrl('mosettings'),
            name: 'Settings'
        }];
    return tabs;
}