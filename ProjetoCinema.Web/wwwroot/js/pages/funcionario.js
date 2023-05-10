var funcionario = (function () {
  var configs = {
    urls: {
      cadastrar: "",
      viewCadastrar: "",
      viewEditar: "",
      editar: "",
      listar: "",
      excluir: "",
    },
  };

  var init = function ($configs) {
    configs = $configs;
  };

  var cadastrar = () => {
    var model = $("#funcionarioForm").serializeObject();

    $.post(configs.urls.cadastrar, model).done(function () {
      listar();
    });
  };

  var viewCadastrar = function () {
    $.get(configs.urls.viewCadastrar)
      .done(function (html) {
        $(".container-lista").hide();
        $(".container-cadastrar").html(html);
        $(".container-cadastrar").show();
      })
      .fail(function () {});
  };

  var editar = function () {
    location.reload();
    var model = $("#form-editar").serializeObject();
    $.post(configs.urls.editar, model)
      .done(() => {
        $(".container-editar").hide();
        $(".container-lista").show();
        $(".container-lista").html();
        listar();
      })
      .fail(function () {
        console.log("erro");
      });
  };

   var viewEditar = function (id) {
    $.get(configs.urls.viewEditar, { id: id })
      .done(function (html) {
        $(".container-listar").hide();
        $(".buttons").hide();
        $(".container-form").hide();
        $(".container-editar").html(html);
        $(".container-editar").show();
      })
      .fail(function () {});
  };

  var listar = function () {
    var model = $("#funcionarioForm").serializeObject();
    $.post(configs.urls.listar, model)
      .done(function (html) {
        $(".container-listar").html(html);
        $(".container-listar").show();
      })
      .fail(function () {});
  };

  var excluir = function (id) {
    var model = { Id: id };
    $.post(configs.urls.excluir, model)
      .done(() => {
        listar();
      })
      .fail(function () {});
  };

  return {
    init: init,
    listar: listar,
    cadastrar: cadastrar,
    viewCadastrar: viewCadastrar,
    viewEditar: viewEditar,
    editar: editar,
    excluir: excluir,
  };
})();
