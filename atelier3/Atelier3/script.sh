function ecrireDico(){
    a="Saisir string"
    e="Saisir entier"
    for j in `seq 1 25`
    do
        echo "$e"
        read i
        echo "$a"
        read s
        echo "dico.Add($i, $s);" >> $1
    done
}
ecrireDico $1 