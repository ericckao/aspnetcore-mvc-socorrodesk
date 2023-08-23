<script>
    document.addEventListener("DOMContentLoaded", function () {
        var dataAberturaInput = document.getElementById("dataAbertura");
    var prazoInput = document.getElementById("Prazo");

    dataAberturaInput.addEventListener("change", function () {
            var dataAbertura = new Date(dataAberturaInput.value);
    if (!isNaN(dataAbertura.getTime())) {
                var prazo = new Date(dataAbertura.getTime() + 7 * 24 * 60 * 60 * 1000); // Adiciona 7 dias em milissegundos
    var prazoFormatado = prazo.toISOString().substring(0, 10); // Formato YYYY-MM-DD
    prazoInput.value = prazoFormatado;
            }
        });

    // Inicialmente, calcule o prazo com base na data de abertura se houver uma data preenchida
    if (dataAberturaInput.value) {
            var dataAberturaInicial = new Date(dataAberturaInput.value);
    if (!isNaN(dataAberturaInicial.getTime())) {
                var prazoInicial = new Date(dataAberturaInicial.getTime() + 7 * 24 * 60 * 60 * 1000);
    var prazoFormatadoInicial = prazoInicial.toISOString().substring(0, 10);
    prazoInput.value = prazoFormatadoInicial;
            }
        }
    });
</script>
