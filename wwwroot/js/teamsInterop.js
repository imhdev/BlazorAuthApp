//var microsoftTeams = document.createElement('script');
//microsoftTeams.setAttribute('src', 'https://statics.teams.cdn.office.net/sdk/v1.6.0/js/MicrosoftTeams.min.js');
//document.head.appendChild(microsoftTeams);


window.getAccessToken = function () {
    try {
        return new Promise((resolve, reject) => {
            microsoftTeams.initialize();
            microsoftTeams.authentication.authenticate({
                url: window.location.origin + "/auth-start.html",
                width: 600,
                height: 535,
                successCallback: (accessToken) => {
                    resolve(accessToken);
                },
                failureCallback: (reason) => {
                    reject(reason);
                }
            });
        });
    }
    catch (err) {
        return err.message;
    }
}


function openDoc() {
    window.location.assign(window.location.origin + "/myPages/steps.html")
}

function prmoiseFunction() {
    try {
        return new Promise((resolve, reject) => {
            microsoftTeams.initialize();
            console.log("started");
            microsoftTeams.authentication.authenticate({
                url: window.location.origin + "/auth-start.html",
                width: 600,
                height: 535,
                successCallback: (accessToken) => {
                    console.log(accessToken);
                    resolve(accessToken);
                },
                failureCallback: (reason) => {
                    console.log(reason);
                    reject(reason);
                }
            });
        });
    }
    catch (err) {
        return err.message;
    }
}


