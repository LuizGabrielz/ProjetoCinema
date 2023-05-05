var funcionario = (function () {
  var configs = {
    urls: {
      cadastrar: "",
      listar: "",
    },
  };

  var init = function ($configs) {
    configs = $configs;
  };

  var cadastrar = () => {
    var model = $("#funcionarioForm").serializeObject();

    $.post(configs.urls.cadastrar, model).done(function () {
      location.href = configs.urls.listar;
    });
  };

  var listar = function () {
    console.log(configs.urls.listar);
    $.get(configs.urls.listar)
      .done(function (html) {
        $(".container-listar").html(html);
        $(".container-listar").show();
      })
      .fail(function () {});
  };

  return {
    init: init,
    listar: listar,
    cadastrar: cadastrar,
  };
})();
