//Primera version - devuelte texto plano
/*
    var http = require('http');
    var server = http.createServer(function (request, response) {
    response.writeHead(200, {
            "Content-Type": "text/plain"
        });
    response.end("Hola Mundo!");
        
        }).listen(8080);

    console.log('Servidor escuchando por el puerto 8080');
*/
//Segunda version - devuelte archivo html
/*
    var http = require('http');
    var fs = require('fs');
    var server = http.createServer(function (request, response) {
    response.writeHead(200, {
                "Content-Type": "text/html"
            });
    fs.readFile('./index.html', (err, file) => {     response.end(file);     });
        }).listen(8080);
        
    console.log('Servidor escuchando por el puerto 8080');
*/
//Tercera version - Async/Thread
/*
    setInterval(() => console.log('funcion 1'), 1000);
    setInterval(() => console.log('funcion 2'), 1000) ;
    
    console.log('starting');
*/
//Cuarta version - emitir eventos
/*
    const EventEmitter = require('events');
    let emitter = new EventEmitter();

    emitter.on('nuevoNumero', n => console.log(n * 2));

    for (let i = 0; i < 10; i++)
    {
        emitter.emit('nuevoNumero', i);
    }

    console.log('Termine el proceso');
*/
//Quinta version - emitir eventos, reaccionar a eventos de manera asincrona
/*
    const EventEmitter = require('events');
    let emitter = new EventEmitter();

    //setImmediate -> tira el código en la Queue en vez de en la Stack ("Async")
    //*Stack - procesos que se ejecutan de manera sincronica
    //*Queue - procesos que se ejecutan de manera "asincronica", cuando Node se quede sin procesos en Stack
    emitter.on('nuevoNumero', n => setImmediate(()=>console.log(n * 2)))

    for (let i = 0; i < 10; i++)
    {
        emitter.emit('nuevoNumero', i);
    }

    console.log('Termine el proceso');
*/
//Sexta version - trabajo con paquetes/modulos propios
/*
    var user = require('./modulo_persona') ;

    console.log(user.name);
    console.log(user.getFullName());
*/
//Septima version - API REST con express

    var express = require('express');
    var config = require('./config');

    global.currentConfig = config['development'];

    console.log(global.currentConfig);

    var app = express();
    
    const users = [{id: 1, name: 'Juan'}, {id: 2, name: 'Pablo'}] ;
    
    app.get('/users', function(req, res) {
    res.send(users) 
    });

    app.get('/users/:id', function(req, res) {
    res.send(users.find((user)=>{return user.id ==req.params.id}));
    });

    app.post('/users', function(req, res) {
    res.send('Hola Mundo!');
    });

    app.put('/users/:id', function(req, res) {
    res.send('Hola Mundo!');
    });

    app.delete('/users/:id', function(req, res) {
    res.send('Hola Mundo!');
    });

    app.listen(8080, function() {
    console.log('Aplicación ejemplo, escuchando el puerto 8080!');
    });

//