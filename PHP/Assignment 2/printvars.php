<?php
/**
 * Created by PhpStorm.
 * User: david.johnson
 * Date: 9/6/2017
 * Time: 10:33 AM
 */

ECHO "<PRE>";
If(isset($_REQUEST) && !empty($_REQUEST)) {
    print_r($_GET);
    print_r($_POST);
    print_r($_COOKIE);
} else {
    echo "_REQUEST is empty";
}

?>