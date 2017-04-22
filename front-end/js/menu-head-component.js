ko.components.register('menu-head', {
    viewModel: function () {
    },
    template:
    '<nav class="navbar navbar-inverse">' +
    '    <div class="container-fluid">'+
    '        <div class="navbar-header">'+
    '        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">'+
    '            <span class="sr-only">Toggle navigation</span>'+
    '            <span class="icon-bar"></span>'+
    '            <span class="icon-bar"></span>'+
    '            <span class="icon-bar"></span>'+
    '        </button>'+
    '        <a class="navbar-brand" href="index.html">Inicio</a>'+
    '        </div>'+
    '<div class="collapse navbar-collapse">'+
    '    <ul class="nav navbar-nav">'+
    '        <li><a href="classificacaogeral.html">Classificação Geral</a></li>'+
    '        <li><a href="pagamentos.html">Pagamentos</a></li>'+
    '        <li><a href="galeria.html">Galeria</a></li>'+
    '    </ul>'+
    '</div>'+
    '</div>'+
    '</nav>'
});