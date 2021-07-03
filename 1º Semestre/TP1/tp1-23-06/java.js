//validar nome 
if (d.nome.value==""){
alert("O campo NOME deve ser preenchido!")

d.nome.style.backgroundColor="red";

d.nome.style.color="#ffffff";
d.nome.focus();
return false;
}
//validar user

if(d.email.value==""){
alert("O campo EMAIL deve ser preenchido!");
d.email.style.backgroundColor="red";

d.email.style.color="#ffffff";
d.email.focus();
return false;
}
//validar email(verificacao de endereco eletronico)
parte1










return false;
}if(d.mensagem.value==""){
alert ("Digite nos a mensagem!");
d.mensagem.style.backgroundColor="red";
d.mensage.style.color="#ffffff";
return false;
d.conheceu.focus();
}
document.cadastro.submit();
}

</script>