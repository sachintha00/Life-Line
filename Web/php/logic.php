<?php

function tabaleSelector($tableName){
    include('Connection.php');
    $username = mysqli_real_escape_string($connection,$_POST['username']);
    $password = mysqli_real_escape_string($connection,$_POST['password']);
    $query = "SELECT * FROM $tableName WHERE 	username = '{$username}' AND password = '{$password}'";

    return mysqli_query($connection,$query);
}

function getValue($query){
    include('Connection.php');
    $result_set = mysqli_query($connection,$query);
    return mysqli_fetch_assoc($result_set);
}

function getResultSet($query){
    include('Connection.php');
    $result_set = mysqli_query($connection,$query);
    return mysqli_fetch_all($result_set,MYSQLI_ASSOC);
}

function getRowCount($query){
    include('Connection.php');
    $result_set = mysqli_query($connection,$query);
    foreach($result_set as $result){
        return $result['count'].'<br>';
    }
}


?>