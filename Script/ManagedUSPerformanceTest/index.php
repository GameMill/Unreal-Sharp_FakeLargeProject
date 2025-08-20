<?php

$file = file_get_contents(__DIR__.'/AdvancedActor.cs');
for ($i = 0; $i < 2001; $i++) {
    $nfile = str_replace("MyShowcaseMulticastDelegate","MyShowcaseMulticastDelegate".$i,$file);
    $nfile = str_replace("AAdvancedActor","AAdvancedActor".$i,$nfile);
    file_put_contents(__DIR__.'/Copies/AdvancedActor'.$i.'.cs', $nfile);
}

