a = 10

tmr.alarm(0, a, 1, function() 
        print("vl =" .. adc.read(0)) 
end )
    pin=1
    gpio.mode(pin, gpio.OUTPUT)
    bil = false;
    tmr.delay(100000)
tmr.alarm(1, 100, 1, function()
    if bil == false then
        gpio.write(pin, gpio.HIGH) 
        bil = true
    else 
        gpio.write(pin, gpio.LOW) 
        bil = false
    end
end )
b = a
tmr.alarm(2,1000,1,function()
    if b ~=a then
    b=a
        tmr.alarm(0, a, 1, function() 
            print("vl =" .. adc.read(0)) 
        end )
    end
end)