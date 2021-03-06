USE weather_app
GO
CREATE TABLE GeneralRequestResponse
(
    id                           INT
    ,date_stamp                  DATETIME
    ,weather_alerts              VARCHAR(1028)
    ,hourly_summary              VARCHAR(1028)
    ,latitude                    GEOGRAPHY
    ,longitude                   GEOGRAPHY
    ,timezone                    VARCHAR(28)
    ,daily                       VARCHAR(500)
    ,flags                       VARCHAR(500)
    ,alerts                      VARCHAR(500)
    ,offset                      VARCHAR(500)
    ,request_time                DATETIME
    ,summary                     VARCHAR(500)
    ,icon                        VARCHAR(500)
    ,nearestStormDistance        DECIMAL
    ,nearestStormBearing         DECIMAL
    ,precipIntensity             DECIMAL
    ,precipProbability           DECIMAL
    ,temperature                 DECIMAL
    ,apparentTemperature         DECIMAL
    ,dewPoint                    DECIMAL
    ,humidity                    DECIMAL
    ,pressure                    DECIMAL
    ,windSpeed                   DECIMAL
    ,windGust                    DECIMAL
    ,windBearing                 DECIMAL
    ,cloudCover                  DECIMAL
    ,uvIndex                     DECIMAL
    ,visibility                  DECIMAL
    ,ozone                       DECIMAL
    ,daily_summary               VARCHAR(500)
    ,daily_icon                  VARCHAR(500)
    ,minutely_datetime           DATETIME
    ,minutely_summary            VARCHAR(28)
    ,minutely_icon               VARCHAR(28)
    ,sunriseTime                 DATETIME
    ,sunsetTime                  DATETIME
    ,moonPhase                   DECIMAL
    ,minutely_precipIntensity    DECIMAL
    ,precipIntensityMax          DECIMAL
    ,precipIntensityMaxTime      DATETIME
    ,minutely_precipProbability  DECIMAL
    ,precipType                  VARCHAR(50)
    ,temperatureHigh             DECIMAL
    ,temperatureHighTime         DATETIME
    ,temperatureLow              DECIMAL
    ,temperatureLowTime          DATETIME
    ,apparentTemperatureHigh     DECIMAL
    ,apparentTemperatureHighTime DATETIME
    ,apparentTemperatureLow      DECIMAL
    ,apparentTemperatureLowTime  DATETIME
    ,minutely_dewPoint           DECIMAL
    ,minutely_humidity           DECIMAL
    ,minutely_pressure           DECIMAL
    ,minutely_windSpeed          DECIMAL
    ,minutely_windGust           DECIMAL
    ,minutely_windGustTime       DATETIME
    ,minutely_windBearing        DATETIME
    ,minutely_cloudCover         DATETIME
    ,minutely_uvIndex            VARCHAR(500)
    ,uvIndexTime                 DATETIME
    ,minutely_visibility         VARCHAR(500)
    ,minutely_ozone              VARCHAR(500)
    ,temperatureMin              VARCHAR(500)
    ,temperatureMinTime          DATETIME
    ,temperatureMax              DECIMAL
    ,temperatureMaxTime          DATETIME
    ,apparentTemperatureMin      DECIMAL
    ,apparentTemperatureMinTime  DATETIME
    ,apparentTemperatureMax      DECIMAL
    ,apparentTemperatureMaxTime  DATETIME
    ,alert_title                 VARCHAR(128)
    ,regions                     VARCHAR(500)
    ,severity                    VARCHAR(55)
    ,alert_time                  DATETIME
)