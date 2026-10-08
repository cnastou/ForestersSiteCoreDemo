USE ForestersDB;
GO

INSERT INTO ContentPages
    (Title, Heading, HeroDescription, Body, ImageUrl, Published)
VALUES
    (
        'Financial confidence for every chapter',
        'Plan with confidence for what comes next',
        'Build a financial plan designed around your goals and the people who matter most.',
        'At Foresters Financial, we help you prepare for the future with financial solutions designed around your life.',
        '',
        1
    );
GO

SELECT *
FROM ContentPages;
GO