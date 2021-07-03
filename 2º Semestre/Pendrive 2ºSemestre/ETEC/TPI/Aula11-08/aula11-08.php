<html>
<head>
<meta charset="utf-8">
<title> Variaveis </title>
</head>
<body>
<strong> Aprendendo Variaveis </strong>

<?php

print date ("d/m/y");

?>
 
<br />
<?php
      $nome = "Aline";
      $n =    "15";
      $idade = "18";
      
      echo "$n<br>";
      echo "$nome<br>";
      echo "$idade<br>";
	  echo "$nome tem $idade anos";

      $n1 = 30;
      $n2 = 50;
      $r = 0;
      
      $r <= $n1 + $n2;
      $r = $n1 + $n2;

      //echo "$r<br>";
      echo "<br>$n1 + $n2 = $r";
      echo "<br> A soma vale:<br>".($n1 + $n2);
	   echo "<br> A subtração vale:<br>".($n1 - $n2);
	    echo "<br> A Divisão vale:<br>".($n1 / $n2);
		 echo "<br> A multiplicação vale:<br>".($n1 * $n2);
		  echo "<br> O resto é:<br>".($n1 % $n2);
		   echo "<br> A média vale:<br>".($n1 + $n2)/2;
		    echo "<br> A raiz quadrada do 1° é:<br>".sqrt($n1);
			 echo "<br>A raiz quadrada do 2° é: <br>".sqrt($n2);
			  echo "<br> A exponenciação é:<br>".pow($n1,$n2);
			  
			  
			  
		   
	     
	  
      
      

?>
 
 

</body>
</html>