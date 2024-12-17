<?php

use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    $data = [
        [
            "id" => 1,
            "nama" => "John Doe",
            "alamat" => "Jalan ABC",
            "kota" => "Jakarta"
        ],
        [
            "id" => 2,
            "nama" => "Jane Doe",
            "alamat" => "Jalan DEF",
            "kota" => "Bandung"
        ],
        [
            "id" => 3,
            "nama" => "Bob Smith",
            "alamat" => "Jalan GHI",
            "kota" => "Surabaya"
        ]
    ];
    return response()->json([
        "data" => $data
    ], 200);
});
