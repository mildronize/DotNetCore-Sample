import React, { useEffect, useState } from "react";
import Layout from "./Layout";
import { RouteComponentProps, useParams, Link } from "react-router-dom";

interface ParamTypes {
  startDateIndex: string;
}

export interface WeatherForecastsState {
  isLoading: boolean;
  startDateIndex?: number;
  forecasts: WeatherForecast[];
}

export interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

const initValue: WeatherForecastsState = {
  isLoading: false,
  startDateIndex: 0,
  forecasts: [],
};

const FetchData = () => {
  const params = useParams<ParamTypes>();
  const [weatherForecasts, setWeatherForecasts] = useState(initValue);

  // This method is called when the component is first added to the document
  useEffect(()=>{
    ensureDataFetched();
  },[]);

  // This method is called when the route parameters change
  useEffect(()=>{
    ensureDataFetched();
  },[params.startDateIndex]);

  const ensureDataFetched = async () => {
    await requestWeatherForecasts(parseInt(params.startDateIndex, 10) || 0);
  };

  const requestWeatherForecasts = async (startDateIndex: number) => {
    // Only load data if it's something we don't already have (and are not already loading)

    // if (startDateIndex !== weatherForecasts.startDateIndex) {
      setWeatherForecasts({
        ...weatherForecasts,
        isLoading: true,
      });
      const response = await fetch("weatherforecast");
      const data = await (response.json() as Promise<WeatherForecast[]>);

      setWeatherForecasts({
        startDateIndex: startDateIndex,
        forecasts: data,
        isLoading: false,
      });
    // }
  };

  const renderForecastsTable = () => {
    return (
      <table className="table table-striped" aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {weatherForecasts.forecasts.map((forecast) => (
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          ))}
        </tbody>
      </table>
    );
  };
  const renderPagination = () => {
    const prevStartDateIndex = (weatherForecasts.startDateIndex || 0) - 5;
    const nextStartDateIndex = (weatherForecasts.startDateIndex || 0) + 5;

    return (
      <div className="d-flex justify-content-between">
        <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-data/${prevStartDateIndex}`}>Previous</Link>
        {weatherForecasts.isLoading && <span>Loading...</span>}
        <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-data/${nextStartDateIndex}`}>Next</Link>
      </div>
    );
  };

  return (
    <Layout>
      <h1 id="tabelLabel">Weather forecast</h1>
      <p>
        This component demonstrates fetching data from the server and working
        with URL parameters.
      </p>
      {renderForecastsTable()}
      {renderPagination()}
    </Layout>
  );
};

export default FetchData;
