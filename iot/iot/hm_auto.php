<!DOCTYPE html>
<html>
<head>
    <title>Raspberry Pi LED Control</title>
</head>
<body style="text-align:center; margin-top:50px;">
    <h2>Control Raspberry Pi LED</h2>
    <form method="post">
        <input type="submit" name="on" value="Turn ON" style="width:120px;height:40px;">
        <input type="submit" name="off" value="Turn OFF" style="width:120px;height:40px;">
    </form>

    <?php
    $raspberry_ip = "192.168.1.228"; // <-- Replace with your Pi's IP address

    if (isset($_POST['on'])) {
        file_get_contents("http://$raspberry_ip:5000/on");
        echo "<p>LED turned ON</p>";
    }

    if (isset($_POST['off'])) {
        file_get_contents("http://$raspberry_ip:5000/off");
        echo "<p>LED turned OFF</p>";
    }
    ?>
</body>
</html>
