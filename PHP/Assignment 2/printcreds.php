<?php
/**
 * User: david.johnson
 * Date: 9/6/2017
 * Time: 10:33 AM
 */

ECHO "<PRE>";
If(isset($_REQUEST) && !empty($_REQUEST)) {
    $UserName = $_POST["name"];
    $PassWord = $_POST["password"];

    echo "Username => {$UserName}\n\n";
    echo "Password => {$PassWord}";

}

?>