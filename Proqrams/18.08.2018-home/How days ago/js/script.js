var date = new Date();
var share_day = new Date(2018, 4, 16, 10, 30, 0, 0);
var diff = date.getTime() - share_day.getTime();
var time = (diff / 1000 / 60).toFixed(0);
var x = 0;
var month = "";

if (time < 60) {
    document.write(`${time} minute ago`);
}
if (time >= 60 && time < 1440) {
    x = (time / 60).toFixed(0);
    document.write(`${x} hour ago`);
}
if (time >= 1440 && time < 4320) {
    x = (time / 60 / 24).toFixed(0);
    document.write(`${x} day ago`);
}
if (time >= 4320 && time < 10080) {
    document.write(`this week`);
}
if (time >= 10080) {
    if (share_day.getMonth() == 0) {
        month = "January";
    }
    if (share_day.getMonth() == 1) {
        month = "February";
    } if (share_day.getMonth() == 2) {
        month = "March";
    } if (share_day.getMonth() == 3) {
        month = "April";
    } if (share_day.getMonth() == 4) {
        month = "May";
    } if (share_day.getMonth() == 5) {
        month = "June";
    } if (share_day.getMonth() == 6) {
        month = "July";
    } if (share_day.getMonth() == 7) {
        month = "August";
    } if (share_day.getMonth() == 8) {
        month = "September";
    } if (share_day.getMonth() == 9) {
        month = "October";
    } if (share_day.getMonth() == 10) {
        month = "November";
    } if (share_day.getMonth() == 11) {
        month = "December";
    }
    document.write(share_day.getFullYear() + " " + month + " " + share_day.getDay());
}