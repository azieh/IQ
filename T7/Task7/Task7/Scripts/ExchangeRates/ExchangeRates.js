var ExchangeRatesController = {
    getUsdAndEurExchangeRates: function (viewModel, exchangeRateVm) {
        viewModel.urlResponse("Request has been sent. Please wait...");
        $.ajax({
            method: "Get",
            url: "/ExchangeRates/GetUsdAndEurExchangeRates/",
            contentType: "application/json",
            dataType: "json",
            success: function (rawData) {
                viewModel.exchangeRatesList([]);
                rawData.forEach(function (x) {
                    var exchangeRate = new exchangeRateVm();
                    exchangeRate.name(x.Name);
                    exchangeRate.value(x.Value);
                    viewModel.exchangeRatesList.push(exchangeRate);
                });
                viewModel.urlResponse("Exchange rates updated");
            },
            error: function () {
                viewModel.urlResponse("Error on request");
            }
        });
    }
};