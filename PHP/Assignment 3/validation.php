<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PHP Assignment 3</title>

    <link rel="stylesheet" href="css/stylesheet.css" type="text/css">

</head>

<body>

<h1> PHP Assignment 3 - Login Page </h1>

<?php

If(isset($_REQUEST) && !empty($_REQUEST)) {

    $_UserName = $_POST["name"];
    $_PassWord = $_POST["password"];

    if ($_UserName === "Paycom" && $_PassWord === "WebTraining") {
        $_HTMLfill = "<h2 class=\"feedbackSuccess\">Username and Password accepted. Welcome!</h2>";
    } else {
        $_HTMLfill = "<h2 class=\"feedbackFail\">The Username and Password combination entered is invalid.</h2>";
    }

    //echo ("$_HTMLfill\n");

    // echo "Username => {$_UserName}\n\n";
    // echo "Password => {$_PassWord}";
}
?>

<div class="form_container2" align="center">
    <?php   echo ("$_HTMLfill\n");   ?>
</div>

<footer class="bottomMenu">
    <p>&copy; David Johnson | 2017</p>
</footer>

<div id="bg">
    <img src="images/bg.jpg" alt="">
</div>

</body>

</html>
