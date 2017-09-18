<?php
/**
 * User: david.johnson
 * Date: 9/6/2017
 * Time: 10:33 AM
 */

ECHO "<PRE>";
If(isset($_REQUEST) && !empty($_REQUEST)) {
    $_UserName = $_POST["name"];
    $_PassWord = $_POST["password"];

    echo "Username => {$_UserName}\n\n";
    echo "Password => {$_PassWord}";

}

?>