<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
$("#selstate").on('change', function () {
    document.getElementById("slecity").value = this.value;
    console.log($("#box2").val());
});
$("#slecity").on('change', function () {
    document.getElementById("selstate").value = this.value;
});
