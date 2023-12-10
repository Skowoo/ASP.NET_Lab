/*
 * Dodając nullowalność (?) do klucza głównego encji podrzędnej unikniemy działania kaskady.
 * ewentualnie użyć metody OnDelete we FluentAPI
 * 
 * Wyjątek przy usuwaniu encji nadrzędnej - może wyrzucić błąd jeśli jawnie nie skasujesz właściciela i wszystkich jego encji podrzędnych
 * 
 * Uwaga na rekurencyjne wezwania (kasowanie, drukowanie (ToString)) - encje mogą wywoływać się nawzajem Usera have Car, Car have User...
 * 
 */

