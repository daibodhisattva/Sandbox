<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PHP Assignment 4</title>

    <link rel="stylesheet" href="css/stylesheet2.css" type="text/css">
    <link rel="stylesheet" href="css/jQueryStyles.css" type="text/css">

</head>

<body>

<h1>PHP Assignment 4</h1>
<h2>David's Mythical Animal Purchasing portal</h2>

<?php

session_start();

If(isset($_REQUEST) && !empty($_REQUEST)) {

    $_total = 0;
    $HTMLfill ="";

    foreach($_POST as $_animal => $_value) {
        /*$HTMLfill = $HTMLfill."<p>".$_animal." - ".$_value."</p>";*/
        $_animalString = str_replace("_"," ",$_animal);
        $HTMLfill = $HTMLfill."<span class='animalDiv'>".$_animalString."</span>";
        $_total = $_total + $_value;
        $_totalCost = number_format($_total, 2, '.', '');
    }

    $_SESSION['selectedAnimals'] = $HTMLfill;
    $_SESSION['totalCost'] = $_totalCost;
}

?>

<div class="form_container3" align="center">

    <p class="pagetitle">You selected the following creatures:</p>
    <span class="animal"><?php echo $HTMLfill; ?></span>
    <p class="pagetitle">For a total price of $<?php  echo $_totalCost;    ?></p><br>

    <form action="page3.php" method="post">
        <input class="formname" type="text" id="name" name="name" width="50px" required placeholder="Your name">
        <input class="formphone" type="text" id="phone" name="phone" width="12px" required placeholder="Your phone"><br>
        <input class="formemail" type="text" id="email" name="email" required placeholder="Your email">
        <input class="formconfemail" type="text" id="confemail" name="confemail" required placeholder="Confirm your email"><br>
        <input class="formaddress" type="text" id="addy" name="addy" required placeholder="Your address">
        <input type="text" id="city" name="city" required placeholder="City">
        <select class="formstate" id="state" name="state">
            <option value="" disabled selected>State</option>
            <option value="AL">Alabama</option>
            <option value="AK">Alaska</option>
            <option value="AZ">Arizona</option>
            <option value="AR">Arkansas</option>
            <option value="CA">California</option>
            <option value="CO">Colorado</option>
            <option value="CT">Connecticut</option>
            <option value="DE">Delaware</option>
            <option value="DC">District Of Columbia</option>
            <option value="FL">Florida</option>
            <option value="GA">Georgia</option>
            <option value="HI">Hawaii</option>
            <option value="ID">Idaho</option>
            <option value="IL">Illinois</option>
            <option value="IN">Indiana</option>
            <option value="IA">Iowa</option>
            <option value="KS">Kansas</option>
            <option value="KY">Kentucky</option>
            <option value="LA">Louisiana</option>
            <option value="ME">Maine</option>
            <option value="MD">Maryland</option>
            <option value="MA">Massachusetts</option>
            <option value="MI">Michigan</option>
            <option value="MN">Minnesota</option>
            <option value="MS">Mississippi</option>
            <option value="MO">Missouri</option>
            <option value="MT">Montana</option>
            <option value="NE">Nebraska</option>
            <option value="NV">Nevada</option>
            <option value="NH">New Hampshire</option>
            <option value="NJ">New Jersey</option>
            <option value="NM">New Mexico</option>
            <option value="NY">New York</option>
            <option value="NC">North Carolina</option>
            <option value="ND">North Dakota</option>
            <option value="OH">Ohio</option>
            <option value="OK">Oklahoma</option>
            <option value="OR">Oregon</option>
            <option value="PA">Pennsylvania</option>
            <option value="RI">Rhode Island</option>
            <option value="SC">South Carolina</option>
            <option value="SD">South Dakota</option>
            <option value="TN">Tennessee</option>
            <option value="TX">Texas</option>
            <option value="UT">Utah</option>
            <option value="VT">Vermont</option>
            <option value="VA">Virginia</option>
            <option value="WA">Washington</option>
            <option value="WV">West Virginia</option>
            <option value="WI">Wisconsin</option>
            <option value="WY">Wyoming</option>
        </select>
        <input class="formzip" type="text" id="zip" name="zip" required placeholder="Zip code"><br><br>
        <input id="submit" type="submit" value="Submit">
    </form>

</div>

<footer class="bottomMenu">
    <p>&copy; David Johnson | 2017</p>
</footer>

<div id="bg">
    <img src="images/bg5.jpg" alt="">
</div>

</body>

<script src="js/jquery-1.10.2.min.js"></script>
<script src="js/jquery-ui-1.10.3.custom.min.js"></script>
<script src="js/scripts.js"></script>

</html>
