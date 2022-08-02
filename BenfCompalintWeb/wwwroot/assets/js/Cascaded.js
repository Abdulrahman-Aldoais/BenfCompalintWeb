﻿$(document).ready(function () {
    GetGovernorate();
    $('#SelectedGovernorate').change(function () {
        var id = $(this).val();
        $('#Directorate').empty();
        $('#Directorate').append('<Option> اختر المديرية</Option>');
        $.ajax({
            url: '/Compalints/SelectedDirectorate?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#Directorate').append('<Option value=' + data.id + '>' + data.Name + '</Option>');
                });
            }
        });
    });

    $('#SelectedDirectorate').change(function () {
        var id = $(this).val();
        $('#SelectedSubDirectorate').empty();
        $('#SelectedSubDirectorate').append('<Option> اختر العزلة</Option>');
        $.ajax({
            url: '/Compalints/SelectedSubDirectorate?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#SelectedSubDirectorate').append('<Option value=' + data.id + '>' + data.Name + '</Option>');
                });
            }
        });
    });

    $('#SelectedVillage').change(function () {
        var id = $(this).val();
        $('#SelectedVillage').empty();
        $('#SelectedVillage').append('<Option> اختر العزلة</Option>');
        $.ajax({
            url: '/Compalints/SelectedVillage?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#SelectedVillage').append('<Option value=' + data.id + '>' + data.Name + '</Option>');
                });
            }
        });
    });


});

function GetGovernorate() {
    $.ajax({
        url: '/Compalints/SelectedGovernorate',
        success: function (result) {
            $.each(result, function (i,data) {
                $('#Governorate').append('<Option value=' + data.id + '>' + data.Name + '</Option>');
            });
        }
    });
}