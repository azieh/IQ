var ExchangeRatesVm = function () {
    var self = this;
    this.controller = ExchangeRatesController;
    this.exchangeRateVm = function() {
        var self = this;
        self.name = ko.observable("");
        self.value = ko.observable("");
    };

    this.exchangeRatesListModel = {
        urlResponse : ko.observable(""),
        exchangeRatesList : ko.observableArray([])
    };

    this.getUsdAndEurExchangeRates = function() {
        self.controller.getUsdAndEurExchangeRates(self.exchangeRatesListModel, self.exchangeRateVm);
    };
};
var obj = new ExchangeRatesVm();
ko.applyBindings(obj);