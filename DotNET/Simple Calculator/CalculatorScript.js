let val = document.getElementById("ip");

function enter(v)
{
    val.value += v;
}

function exe()
{
    val.value = eval(val.value);
}

function cls()
{
    val.value = "";
}