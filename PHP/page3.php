<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PHP Assignment 4</title>

    <link rel="stylesheet" href="css/stylesheet.css" type="text/css">

</head>

<body>

<h1>PHP Assignment 4</h1>
<h2>David's Mythical Animal Purchasing portal</h2>

<?php

session_start();

If(isset($_REQUEST) && !empty($_REQUEST)) {

    $_selectedAnimals = $_SESSION['selectedAnimals'];
    $_totalCost = $_SESSION['totalCost'];
    $_orderName = $_POST['name'];
    $_firstName = explode(' ',trim($_orderName));
    $_orderFill = "";
    $_orderFill = $_orderFill.$_POST['addy'].", ".$_POST['city'].", ".$_POST['state'].", ".$_POST['zip'];
}

?>

<div class="form_container4" align="center">

    <p class="pagetitle">Order Confirmation for: <?php echo $_firstName[0]; ?></p>
    <span class="animal"><?php echo $_selectedAnimals; ?></span>
    <p class="pagetitle">Total price of $<?php  echo $_totalCost;    ?></p><br>
    <p class="pagetitle">Shipping Location:</p>
    <span class="animal"><span class="orderDetails"> <?php echo $_orderName; ?><br><?php echo $_orderFill ?><br><?php echo $_POST['phone']; ?> | <?php echo $_POST['email']; ?></span></span>



</div>

<footer class="bottomMenu">
    <p>&copy; David Johnson | 2017</p>
</footer>

<div id="bg">
    <img src="images/bg5.jpg" alt="">
</div>

</body>

</html>
