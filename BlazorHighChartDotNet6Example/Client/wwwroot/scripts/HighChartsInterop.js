
window.FormatterFunction = function () {
        return this.value + ' %';
}

function FunctionX(chartOptions) {
    json = JSON.parse(chartOptions);

    json["xAxis"][0]["labels"]["formatter"] = new Function(json["xAxis"][0]["labels"]["formatter"]);

    new Highcharts.chart("chart", json);
}
