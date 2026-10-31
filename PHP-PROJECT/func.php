<?php
$con=mysqli_connect("localhost","root",""," ");
if(isset($_POST['login_submit'])){
$username=$_POST['username'];
$password=$_POST['password'];

if(empty($username)||empty($password))
{
	echo "<script>alert('Error login,Please enter all the info user Name and password')</script>";
	echo "<script>window.open('login.php','_self')</script>";
	exit();
}
else
{
$query="select * from logintb where username='$username' and password='$password'";
$result=mysqli_query($con,$query);
if(mysqli_num_rows($result)==1)
{
	header("Location:admin_panel.php");
}

else
{
	echo "<script>alert('Error login,Please provide all the info')</script>";
	echo "<script>window.open('login.php','_self')</script>";
}
}
}

if(isset($_POST['client_submit']))
{
	$name=$_POST['name'];
	$contact=$_POST['contact'];
	$email=$_POST['email'];
	$company=$_POST['company'];
	$amount=$_POST['amount'];
	$clientappt=$_POST['clientappt'];

	if(empty($fname)||empty($lname)||empty($email)||empty($contact)||empty($clientappt))
		{
			echo "<script>alert('Error login,Please enter all the info user Name and password')</script>";
			echo "<script>window.open('admin_panel.php','_self')</script>";
		exit();
		}
	else
	
	$query="insert into clientapp(Regno,fname,lname,email,contact,clientappt)values('$name','$fname','$lname','$email','$contact','$clientappt')";
	$result=mysqli_query($con,$query);
	if($result)
	{
		echo "<script>alert('Data Has Been Registered succecfully.')</script>";
		
		echo "<script>window.open('index.html','_self')</script>";
	}
}


function get_client_details(){
	global $con;
	$query="select * from clientapp";
	$result=mysqli_query($con,$query);
	while($row=mysqli_fetch_array($result)){
		$Regno=$row['Regno'];
		$fname=$row['fname'];
		$lname=$row['lname'];
		$email=$row['email'];
		$contact=$row['contact'];
		$clientappt=$row['clientappt'];
		echo "<tr>
			<td>$Regno</td>
			<td>$fname</td>
			<td>$lname</td>
			<td>$email</td>
			<td>$contact</td>
			<td>$clientappt</td>
			</td>";
	}
}

if(isset($_POST['client_update']))
{
	$Regno=$_POST['Regno'];	
	$fname=$_POST['fname'];
	$lname=$_POST['lname'];
	$email=$_POST['email'];
	$contact=$_POST['contact'];
	$clientappt=$_POST['clientappt'];

	if(empty($fname)||empty($lname)||empty($email)||empty($contact)||empty($clientappt))
		{
			echo "<script>alert('Error to upadte,Please enter all the info needed to update by using contact no.')</script>";
			echo "<script>window.open('client_update.php','_self')</script>";
		exit();
		}
	else
	
	$query="update clientapp set Regno='$Regno',fname='$fname',lname='$lname',email='$email',contact='$contact',clientappt='$clientappt' where Regno='$Regno';";
	$result=mysqli_query($con,$query);
	
	if($result)
	{
		echo "<script>alert('Data Has Been Updated succecfully.')</script>";
		
		echo "<script>window.open('index.html','_self')</script>";
	}
	
}


if(isset($_POST['client_delete']))
{
	$Regno=$_POST['Regno'];	
	$fname=$_POST['fname'];
	$lname=$_POST['lname'];
	$email=$_POST['email'];
	$contact=$_POST['contact'];
	$clientappt=$_POST['clientappt'];

	if(empty($fname)||empty($lname)||empty($email)||empty($contact)||empty($clientappt))
		{
			echo "<script>alert('Error to upadte,Please enter all the info needed to update by using contact no.')</script>";
			echo "<script>window.open('client_update.php','_self')</script>";
		exit();
		}
	else
	
	$query="delete from clientapp where Regno='$Regno';";
	$result=mysqli_query($con,$query);
	
	if($result)
	{
		echo "<script>alert('Data Has Been delete succecfully.')</script>";
		
		echo "<script>window.open('index.html','_self')</script>";
	}	
}

?>