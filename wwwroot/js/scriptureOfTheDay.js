const remarkableScriptures = [
    {
        book: "1 Nephi",
        chapter: 11,
        verse: 13,
        scripture: "And it came to pass that I looked and beheld the great city of Jerusalem, and also other cities. And I beheld the city of Nazareth; and in the city of Nazareth I beheld a virgin, and she was exceedingly fair and white."
    },
    {
        book: "2 Nephi",
        chapter: 25,
        verse: 26,
        scripture: "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."
    },
    {
        book: "2 Nephi",
        chapter: 26,
        verse: 12,
        scripture: "And as I spake concerning the convincing of the Jews, that Jesus is the very Christ, it must needs be that the Gentiles be convinced also that Jesus is the Christ, the Eternal God."
    },
    {
        book: "2 Nephi",
        chapter: 31,
        verse: 20,
        scripture: "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."
    },
    {
        book: "2 Nephi",
        chapter: 33,
        verse: 10,
        scripture: "And now, my beloved brethren, and also Jew, and all ye ends of the earth, hearken unto these words and believe in Christ; and if ye believe not in these words believe in Christ. And if ye shall believe in Christ ye will believe in these words, for they are the words of Christ, and he hath given them unto me; and they teach all men that they should do good."
    },
    {
        book: "Mosiah",
        chapter: 3,
        verse: 5,
        scripture: "For behold, the time cometh, and is not far distant, that with power, the Lord Omnipotent who reigneth, who was, and is from all eternity to all eternity, shall come down from heaven among the children of men, and shall dwell in a tabernacle of clay, and shall go forth amongst men, working mighty miracles."
    },
    {
        book: "Mosiah",
        chapter: 15,
        verse: 1,
        scripture: "And now Abinadi said unto them: I would that ye should understand that God himself shall come down among the children of men, and shall redeem his people."
    },
    {
        book: "Alma",
        chapter: 7,
        verse: 10,
        scripture: "And behold, he shall be born of Mary, at Jerusalem which is the land of our forefathers, she being a virgin, a precious and chosen vessel, who shall be overshadowed and conceive by the power of the Holy Ghost, and bring forth a son, yea, even the Son of God."
    },
    {
        book: "Alma",
        chapter: 34,
        verse: 8,
        scripture: "And now, behold, I will testify unto you of myself that these things are true. Behold, I say unto you, that I do know that Christ shall come among the children of men, to take upon him the transgressions of his people, and that he shall atone for the sins of the world; for the Lord God hath spoken it."
    },
    {
        book: "3 Nephi",
        chapter: 11,
        verse: 10,
        scripture: "Behold, I am Jesus Christ, whom the prophets testified shall come into the world."
    },
    {
        book: "3 Nephi",
        chapter: 27,
        verse: 13,
        scripture: "Behold I have given unto you my gospel, and this is the gospel which I have given unto you—that I came into the world to do the will of my Father, because my Father sent me."
    },
    {
        book: "Ether",
        chapter: 3,
        verse: 14,
        scripture: "Behold, I am he who was prepared from the foundation of the world to redeem my people. Behold, I am Jesus Christ. I am the Father and the Son. In me shall all mankind have life, and that eternally, even they who shall believe on my name; and theyare the scriptures contained in the Book of Mormon."
    }
    ]
const scriptureDay = () => {
    let p = document.getElementById("scriptureOfTheDay");
    let info = document.getElementById("authorAndVerse"); 

    const randomScripture = remarkableScriptures[Math.floor(Math.random() * remarkableScriptures.length)];

    p.textContent = `"${randomScripture.scripture}"`
    info.textContent = `${randomScripture.book}: ${randomScripture.chapter}:${randomScripture.verse}`
}

window.onload = scriptureDay();